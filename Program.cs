using EjemploOData.Models;
using EjemploOData.Services;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



#region ConfigurarOData
var modelBuilderOData = new ODataConventionModelBuilder();
// el string  enviado es el nombre del controlador Odata encargado de administrar a la entidad pasada, (notese que se obvia el Controller en del nombre)
modelBuilderOData.EntitySet<Student>("ODataStudent");
//añadir al controlador
builder.Services.AddControllers().AddOData(optionsOData =>
{
    optionsOData.AddRouteComponents("odata", modelBuilderOData.GetEdmModel())
                .Select()
                .Filter()
                .Count()
                //.SetMaxTop(1000)
                .SetMaxTop(3);
});
#endregion


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region AgregarServiciosPropios
builder.Services.AddTransient<IStudentService, StudentService>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseODataRouteDebug();
}

app.UseAuthorization();



app.MapControllers();

app.Run();
