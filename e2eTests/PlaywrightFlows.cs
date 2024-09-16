using Microsoft.Playwright;

namespace e2eTests;

public class PlaywrightFlows
{

    private string email;
    private string password;
    private IPlaywright playwright;
    private IBrowser browser;
    private IBrowserContext context;
    private IPage Page;

    public PlaywrightFlows()
    {
        // Call an async method to handle the initialization
        Task.Run(async () => await SetUp()).GetAwaiter().GetResult();
    }

    ~PlaywrightFlows()
    {
        Task.Run(async () => await context.CloseAsync()).GetAwaiter().GetResult();
        Task.Run(async () => await browser.CloseAsync()).GetAwaiter().GetResult();
        playwright.Dispose();
    }

    public async Task SetUp()
    {
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true, // Set to false to run in headed mode
            SlowMo = 50       // Optional: Slow down actions by 50ms to observe interactions
        }); ;
        context = await browser.NewContextAsync();
        Page = await context.NewPageAsync();
        email = System.Environment.GetEnvironmentVariable("EMAIL");
        password = System.Environment.GetEnvironmentVariable("PASSWORD");
    }

    public async Task<bool> CompletePayment(string checkoutUrl)
    {
        try
        {
            await Page.GotoAsync(checkoutUrl);
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                await Page.FillAsync("#email", email);

                if (await Page.IsVisibleAsync("#btnNext"))
                {
                    await Page.ClickAsync("#btnNext");
                }

                await Page.FillAsync("#password", password);
                await Page.ClickAsync("#btnLogin");

                try
                {
                    // Check if the payment-submit-btn is visible
                    await Page.WaitForSelectorAsync("#payment-submit-btn", new PageWaitForSelectorOptions { Timeout = 10000 });
                }
                catch (TimeoutException)
                {
                    // If the error Page is shown, go back and wait for the payment button
                    await Page.GoBackAsync();
                    await Page.WaitForSelectorAsync("#payment-submit-btn");
                }

                await Page.ClickAsync("#payment-submit-btn");

                try
                {
                    await Page.WaitForURLAsync("https://example.com/returnUrl**", new PageWaitForURLOptions { Timeout = 10000 });
                }
                catch (TimeoutException)
                {
                    await Page.ReloadAsync();
                    await Page.WaitForURLAsync("https://example.com/returnUrl**", new PageWaitForURLOptions { Timeout = 10000 });
                }

                return true;
            }
            else
            {
                throw new Exception("EMAIL or PASSWORD environment variable is not set");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error completing payment: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> SavePaymentMethod(string url)
    {
        try
        {
            // Navigate to the provided URL
            await Page.GotoAsync(url);

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Fill in the email
                await Page.FillAsync("#email", email);

                // If the Next button is visible, click it
                if (await Page.IsVisibleAsync("#btnNext"))
                {
                    await Page.ClickAsync("#btnNext");
                }

                // Fill in the password
                await Page.FillAsync("#password", password);
                await Page.ClickAsync("#btnLogin");

                try
                {
                    // Wait for the consent button to appear
                    await Page.WaitForSelectorAsync("#consentButton", new PageWaitForSelectorOptions { Timeout = 5000 });
                }
                catch (TimeoutException)
                {
                    // If there's an error Page, go back and wait for the consent button again
                    await Page.GoBackAsync();
                    await Page.WaitForSelectorAsync("#consentButton");
                }

                // Click the consent button
                await Page.ClickAsync("#consentButton");

                try
                {
                    // Wait for the return URL to be reached
                    await Page.WaitForURLAsync("https://example.com/returnUrl**", new PageWaitForURLOptions { Timeout = 10000 });
                }
                catch (TimeoutException)
                {
                    // If the return URL isn't reached, reload the Page and wait again
                    await Page.ReloadAsync();
                    await Page.WaitForURLAsync("https://example.com/returnUrl**", new PageWaitForURLOptions { Timeout = 10000 });
                }

                return true;
            }
            else
            {
                throw new Exception("EMAIL or PASSWORD environment variable is not set");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error saving payment method: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> CompleteHeliosVerification(string checkoutUrl, bool submitFormVerification)
    {
        try
        {
            // Navigate to the provided checkout URL
            await Page.GotoAsync(checkoutUrl);

            // Wait for the specific Helios URL or reload if not found
            try
            {
                await Page.WaitForURLAsync("https://www.sandbox.paypal.com/webapps/helios?action=verify&flow=3ds**",
                    new PageWaitForURLOptions { Timeout = 10000 });
            }
            catch (TimeoutException)
            {
                await Page.ReloadAsync();
                await Page.WaitForURLAsync("https://www.sandbox.paypal.com/webapps/helios?action=verify&flow=3ds**",
                    new PageWaitForURLOptions { Timeout = 10000 });
            }

            if (submitFormVerification)
            {
                // Wait until all network calls are finished (i.e., the Page is fully loaded)
                await Page.WaitForLoadStateAsync(LoadState.NetworkIdle, new PageWaitForLoadStateOptions { Timeout = 10000 });

                // Locate the iframe and then the input field and submit button inside it
                var frame = Page.FrameLocator("iframe[name=\"threedsIframeV2\"]")
                                 .FrameLocator("iframe");

                var inputField = frame.GetByPlaceholder(" Enter Code Here");

                // Interact with the input field and submit button if they are visible
                if (await inputField.IsVisibleAsync())
                {
                    await inputField.ClickAsync();
                    await inputField.FillAsync("1234");
                }

                var submitButton = frame.GetByRole(AriaRole.Button, new() { Name = "SUBMIT" });

                if (await submitButton.IsVisibleAsync())
                {
                    await submitButton.ClickAsync();
                }
            }
            // Wait for the return URL, reload if not found
            try
            {
                await Page.WaitForURLAsync("https://example.com/returnUrl**",
                    new PageWaitForURLOptions { Timeout = 10000 });
            }
            catch (TimeoutException)
            {
                await Page.ReloadAsync();
                await Page.WaitForURLAsync("https://example.com/returnUrl**",
                    new PageWaitForURLOptions { Timeout = 10000 });
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error completing payment: {ex.Message}");
            return false;
        }
    }
}