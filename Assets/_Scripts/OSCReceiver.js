#pragma strict

public var RemoteIP : String = "127.0.0.1"; //127.0.0.1 signifies a local host (if testing locally
public var SendToPort : int = 9000; //the port you will be sending from
public var ListenerPort : int = 8050; //the port you will be listening on
public var controller : Transform;
public var gameReceiver = "Cube"; //the tag of the object on stage that you want to manipulate
private var handler : Osc;
//private var beta_values: float;

//VARIABLES YOU WANT TO BE ANIMATED
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

function Update () {
	var go = GameObject.Find(gameReceiver);
	go.transform.Rotate(0, yRot, 0);
}

//These functions are called when messages are received
//Access values via: oscMessage.Values[0], oscMessage.Values[1], etc

public function AllMessageHandler(oscMessage: OscMessage){


	var msgString = Osc.OscMessageToString(oscMessage); //the message and value combined
	var msgAddress = oscMessage.Address; //the message parameters
	var msgValue = oscMessage.Values[0]; //the message value
	Debug.Log(msgString); //log the message and values coming from OSC
	

	if(msgAddress == "/muse/elements/touching_forehead")
	{
		if(msgValue == 1)
			GameManager.instance.device = true;
		else {
			Debug.Log("Please adjust the headset so that all channels are receiving data");
			GameManager.instance.device = true;
			}
	}
	
	
	
	//FUNCTIONS YOU WANT CALLED WHEN A SPECIFIC MESSAGE IS RECEIVED
	switch (msgAddress){
		case "/muse/elements/experimental/concentration": 
			Debug.Log("Conentration");
			//var value = msgValue * 10;
			Rotate(msgValue);
			//Debug.Log("one: " + beta_values[0] + " two : " +  beta_values[1] +
			// " three: " + beta_values[2] + " four: " + beta_values[4]);
			//Rotate(beta_values[2]);
		default:
			Debug.Log("Not concentrating");
			//Rotate(oscMessage.Values[2]);
			break;
	}

}


//FUNCTIONS CALLED BY MATCHING A SPECIFIC MESSAGE IN THE ALLMESSAGEHANDLER FUNCTION
public function Rotate(msgValue) : void //rotate the cube around its axis
{
	yRot = msgValue;
}
