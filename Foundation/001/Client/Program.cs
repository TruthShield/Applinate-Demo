// Bootstrap the app - only done when the application first starts
Applinate.InitializationProvider.Initialize();

// define the app sending the service request
var appKey = new AppContextKey(SequentialGuid.NewGuid(), 0, 0, 1);

// get a client
var sc = new ServiceClient(Guid.NewGuid(), appKey);

// start a new conversation (request) for required context
sc.StartNewConversation();

var request = new MyRequest(1, 2);
var response = await request.ExecuteAsync();

Console.WriteLine(response.Value1);
Console.ReadKey();
