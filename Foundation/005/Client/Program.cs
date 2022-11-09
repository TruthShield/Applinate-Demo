// Bootstrap the app - only done when the application first starts
Applinate.InitializationProvider.Initialize();

// define the app sending the service request
var appKey = new AppContextKey(SequentialGuid.NewGuid(), 0, 0, 1);

// get a client
var sc = new ServiceClient(Guid.NewGuid(), appKey);

// start a new conversation (request) for required context
sc.StartNewConversation();

var command = new MyCommmand(5);
_ = await command.ExecuteAsync(CancellationToken.None);

Console.ReadKey();