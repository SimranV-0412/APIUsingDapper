using APIUsingDapper.OperationFilters;
using LibraryManagementSystem.DAL;
using LibraryManagementSystem.DAL.Interface;
//using LibraryManagementSystem.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddScoped<CustomMiddleware>();

builder.Services.AddScoped<ILibrary, LibraryRepo>();

builder.Services.AddSwaggerGen(
    //options =>
    //{
    //    options.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Api", Version = "v1" });
    //    options.AddSecurityDefinition(name: "oauth2", new OpenApiSecurityScheme
    //    {
    //        Type = SecuritySchemeType.OAuth2,
    //        Flows = new OpenApiOAuthFlows
    //        {
    //            ClientCredentials = new OpenApiOAuthFlow
    //            {
    //                TokenUrl = new Uri("https://localhost:7071/connect/tokens"),
    //                Scopes = new Dictionary<string, string>
    //            {
    //                { "api", "API" }
    //            }
    //            }
    //        }
    //    });
    //    options.OperationFilter<AuthorizeOperationFilter>();
    //    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
    //}

    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "JWTToken_Auth_API",
            Version = "v1"
        });

        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
        {
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
        });

        c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
        });
    });

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();
//app.UseMiddleware<CustomMiddleware>();
app.MapControllers();


app.Run();