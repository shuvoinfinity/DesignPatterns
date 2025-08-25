// See https://aka.ms/new-console-template for more information
using DesignPatterns.Coupling;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.State;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Iterator;

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

// var document = new Document(UserRoles.Admin);
// Console.WriteLine(document.State);
// document.Publish();
// Console.WriteLine(document.State);
// document.Publish();
// Console.WriteLine(document.State);
// document.State = new DraftState(document);
// Console.WriteLine(document.State);
#endregion

#region Strategy Pattern

// string fileName = "/file/my_video.mp4";
// var videoStorage = new VideoStorage(new CompressMov(), new OverlayBlur());
// videoStorage.StoreVideo(fileName);

// videoStorage.SetCompressor(new CompressMp4());
// videoStorage.SetOverlay(new OverlayBlackAndWhite());
// videoStorage.StoreVideo(fileName);
#endregion

#region Iterator Pattern
var shoppingList = new ShoppingList();
shoppingList.AddItem("Milk");
shoppingList.AddItem("Water");
shoppingList.AddItem("Tea");

var iterator = shoppingList.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}
#endregion


Console.WriteLine($"CompletedAt - {DateTime.Now}");