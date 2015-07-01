#pragma strict

public var RemoteIP : String = "127.0.0.1"; //127.0.0.1 signifies a local host (if testing locally
public var SendToPort : int = 9000; //the port you will be sending from
public var ListenerPort : int = 8050; //the port you will be listening on
public var controller : Transform;
public var gameReceiver = "Cube"; //the tag of the object on stage that you want to manipulate
private var handler : Osc;
private var concentration: float; //Variable to store the beta value
private var rotation: float; //Varaible by which to rotate the cube

private var yRot : int = 0; //the rotation around the y axis

public function Start ()
{
	//Initializes on start up to listen for messages
	//make sure this game object has both UDPPackIO and OSC script attached
	
	var udp : UDPPacketIO = GetComponent("UDPPacketIO");
	udp.init(RemoteIP, SendToPort, ListenerPort);
	handler = GetComponent("Osc");
	handler.init(udp);
	handler.SetAllMessageHandler(AllMessageHandler);

}
Debug.Log("Running");

function Update () 
{

}

//These functions are called when messages are received
//Access values via: oscMessage.Values[0], oscMessage.Values[1], etc

public function AllMessageHandler(oscMessage: OscMessage){


	var msgString = Osc.OscMessageToString(oscMessage); // The message and value combined
	var msgAddress = oscMessage.Address; // The message parameters
	concentration = oscMessage.Values[0]; //The first value of the message

	Debug.Log("Concentration: " + concentration);
	Debug.Log(msgString);

	if(msgAddress == "/muse/elements/touching_forehead")
	{
		if(concentration == 1) 
		{
			DeviceManager.instance.device = true; //Device Manager is a C# script. It has a variable called deivce. 
			Debug.Log("Device Connected");
		}
		else 
		{
			Debug.Log("Please adjust the headset so that all channels are receiving data");
			DeviceManager.instance.device = false;
		}
	}
	
	
	
	//FUNCTIONS YOU WANT CALLED WHEN A SPECIFIC MESSAGE IS RECEIVED
	switch (msgAddress)
	{
		case "/muse/elements/beta_relative": 
				concentration = oscMessage.Values[2]; //Store the beta value from the right forehead channel and impli change 
													// the type of oscMessage.Values[2] from object to float
				if(concentration >=0)
				{
					DeviceManager.instance.previousBeta = DeviceManager.instance.beta; //Keep track of the previous beta value
					DeviceManager.instance.beta = concentration*10; //Keep track of current beta value
				}

		default:
			Debug.Log(concentration);

			break;
	}
}

