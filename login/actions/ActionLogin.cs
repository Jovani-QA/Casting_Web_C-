using CastingWeb.Pages;
using TestProject8.config;

public class Actions
{
    private PageLogin _page;
    private User _user;

    public Actions(PageLogin page, User user)
    {
        _page = page;
        _user = user;
    }

    public void FazerLogin()
    {
        _page.UsuarioInput.SendKeys(_user.Username);
        _page.SenhaInput.SendKeys(_user.Password);
        _page.EntrarButton.Click();
    }
}
