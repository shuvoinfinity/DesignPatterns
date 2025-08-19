// See https://aka.ms/new-console-template for more information
using DesignPatterns.Coupling;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.State;

Console.WriteLine($"Hello, World! StartedAt - {DateTime.Now}");

// Order order = new Order(new EmailSender());
// order.PlaceOrder();

// Order order1 = new Order(new SmsSender());
// order1.PlaceOrder();

#region Momento Pattern

// Editor editor = new Editor();
// History editorHistory = new History(editor);
// editor.Title = "First Title";
// editorHistory.Backup();
// editor.Content = "Hello world! I am writing this momento";
// editorHistory.Backup();
// editor.Title = "Momento";
// editorHistory.Backup();
// editor.Content = "I am done for today";
// System.Console.WriteLine($"Title: {editor.Title}, Content: {editor.Content}");
// editorHistory.Undo();
// System.Console.WriteLine($"Title: {editor.Title}, Content: {editor.Content}");
// editorHistory.ShowHistory();

#endregion

#region State Pattern

var document = new Document(UserRoles.Admin);
Console.WriteLine(document.State);
document.Publish();
Console.WriteLine(document.State);
document.Publish();
Console.WriteLine(document.State);
document.State = new DraftState(document);
Console.WriteLine(document.State);
#endregion




Console.WriteLine($"CompletedAt - {DateTime.Now}");