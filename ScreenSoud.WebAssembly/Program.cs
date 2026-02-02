using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScreenSoud.WebAssembly;
using ScreenSoud.WebAssembly.Services;

// Criação do host da aplicação WebAssembly
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Injeção de dependência dos serviços
builder.Services.AddTransient<ArtistasAPI>();
builder.Services.AddTransient<MusicasAPI>();

// Configuração do HttpClient para comunicação com a API
builder.Services.AddHttpClient("API",client => 
{
	client.BaseAddress = new Uri(builder.Configuration["APIServer"]);
	client.DefaultRequestHeaders.Add("Accept", "application/json");
});

// Registro dos componentes raiz
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuração do HttpClient padrão
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Execução da aplicação
await builder.Build().RunAsync();
