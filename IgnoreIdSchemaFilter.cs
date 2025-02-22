using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using WebAPI.Models;

public class IgnoreIdSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type == typeof(Student))
        {
            // Xóa thuộc tính Id khỏi Swagger
            schema.Properties.Remove("id");
            schema.Required.Remove("id");
        }
    }
}