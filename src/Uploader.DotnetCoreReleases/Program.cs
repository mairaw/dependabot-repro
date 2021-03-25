using McMaster.Extensions.CommandLineUtils;

namespace Uploader.DotnetCoreReleaseData
{
    class Program
    {
        public static int Main(string[] args) => CommandLineApplication.Execute<Program>(args);
    }
}
