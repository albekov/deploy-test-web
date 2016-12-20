using Owin;

namespace DeployTestWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.Run(async ctx => await ctx.Response.WriteAsync("Hello World!"));
        }
    }
}