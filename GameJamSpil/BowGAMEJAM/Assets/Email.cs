using UnityEngine;
using System.Collections;
using System.Net.Mail;

public class Email : MonoBehaviour {
    public static Email instanceEmail;
    // Use this for initialization
    void Awake() {
        instanceEmail = this;

    }
    void Start () {
        
    }
   /* public void SendMail() {
        Debug.Log("Sending dem mails!");
        MailMessage mail = new MailMessage("you@im2b.dk", "takana@exelion.dk");
        SmtpClient client = new SmtpClient();
        client.Port = 25;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Host = "asmtp.unoeuro.com";
        mail.Subject = "this is a test email.";
        mail.Body = "Årh hvad! Hening er død!";
        client.Send(mail);
    }
	*/

	// Update is called once per frame
	void Update () {
	
	}
}
