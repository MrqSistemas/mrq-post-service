using Microsoft.EntityFrameworkCore;
using YourProjectName.Infra.Configurations;
using YourProjectName.Repository.Context;

var _builder = WebApplication.CreateBuilder(args);
var _services = _builder.Services;

_services.AddControllers();
_services.AddEndpointsApiExplorer();
_services.AddSwaggerGen();
_services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(
        _builder.Configuration.GetConnectionString("TemplateConnection"));
});
_services.AddControllersWithViews();
_services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


ConfigureServices.AddAdapters(_services);
ConfigureServices.AddBusiness(_services);
ConfigureServices.AddApplications(_services);

var _app = _builder.Build();

if (_app.Environment.IsDevelopment())
{
    _app.UseSwagger();
    _app.UseSwaggerUI();
}
_app.UseHttpsRedirection();
_app.UseAuthorization();
_app.MapControllers();
_app.Run();
