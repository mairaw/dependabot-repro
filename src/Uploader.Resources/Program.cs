using McMaster.Extensions.CommandLineUtils;

namespace Uploader.Resources
{
    class Program
    {
        public static int Main(string[] args) => CommandLineApplication.Execute<Program>(args);
    }
}
