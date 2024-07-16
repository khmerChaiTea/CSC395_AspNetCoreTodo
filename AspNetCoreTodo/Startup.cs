public void ConfigureServices(IServiceCollection services)
{
    // (... some code)
    services.AddSingleton<ITodoItemService, FakeTodoItemService>();
    
    services.AddMvc();
}

