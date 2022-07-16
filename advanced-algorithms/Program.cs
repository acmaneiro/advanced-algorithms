using advanced_algorithms.Data;
using advanced_algorithms.Trees;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var myTree = new BinaryTree<int>();
myTree.SimpleInsertNode(1);
myTree.SimpleInsertNode(2);
myTree.SimpleInsertNode(3);
myTree.SimpleInsertNode(4);
myTree.SimpleInsertNode(5);
myTree.SimpleInsertNode(6);
myTree.SimpleInsertNode(7);
myTree.SimpleInsertNode(8);
myTree.SimpleInsertNode(9);
myTree.SimpleInsertNode(10);
myTree.SimpleInsertNode(11);

//Console.WriteLine("In order traversal");
//myTree.InOrderTraversal();
//Console.WriteLine("Pre order traversal");
//myTree.PreOrderTraversal();
//Console.WriteLine("Post order traversal");
//myTree.PostOrderTraveral();
Console.WriteLine(myTree.IsCompleteBinaryTree());

var myTreeIncomplete = new BinaryTree<int>();
myTreeIncomplete.Head = new BinaryTreeNode<int>
{
    Value = 1,
    Left = new BinaryTreeNode<int> {
        Value = 2,
        Left = new BinaryTreeNode<int>
        {
            Value = 4,
            Left = new BinaryTreeNode<int> { Value = 5 },
            Right = new BinaryTreeNode<int> { Value = 6 },
        }
    },
    Right = new BinaryTreeNode<int> { Value = 3},
};
Console.WriteLine("In order traversal");
myTreeIncomplete.InOrderTraversal();
Console.WriteLine("Pre order traversal");
myTreeIncomplete.PreOrderTraversal();
Console.WriteLine("Post order traversal");
myTreeIncomplete.PostOrderTraveral();
Console.WriteLine(myTreeIncomplete.IsCompleteBinaryTree());


app.Run();
