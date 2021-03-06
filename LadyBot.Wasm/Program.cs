using System.Threading.Tasks;
using LadyBot.Program;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace LadyBot.Wasm
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			builder.Services.AddLadyBot();

			await builder.Build().RunAsync();
		}
	}
}
