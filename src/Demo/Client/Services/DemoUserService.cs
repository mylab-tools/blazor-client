using MyLab.BlazorApp.Services;

namespace Demo.Client.Services
{
    public class DemoUserService : IUserService
    {
        public UserInfo ProvideCurrentUser()
        {
            return new UserInfo
            {
                Name = "Andrey O.",
                UserPicUrl = "img/user.png",
                Subtitles = new []
                {
                    "S. Developer",
                    "Moscow"
                },
                Gauges = new[]
                {
                    new UserGauge
                    {
                        Title = "Account value",
                        FaClass = "dollar-sign",
                        Url = "#",
                        AdditionLinkUrl = "#",
                        AdditionLinkTitle = "bill",
                        Value = "1300"
                    },
                    new UserGauge
                    {
                        Title = "Disk space",
                        FaClass = "hdd",
                        Url = "#",
                        Value = "20%"
                    }
                }
            };
        }
    }
}
