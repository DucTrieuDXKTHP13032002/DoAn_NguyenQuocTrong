using Microsoft.AspNetCore.Builder;
using Acme.QLSV;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<QLSVWebTestModule>();

public partial class Program
{
}
