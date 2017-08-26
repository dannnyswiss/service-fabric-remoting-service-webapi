using Owin;

namespace WebApiOwin
{
    public interface IOwinAppBuilder
    {
        void Configuration(IAppBuilder appBuilder);
    }
}
