using Soild.Order;
using Soild.Order.OrderDbAction;
using Soild.Sms;
using Soild.User;

User user = new User(3,"","","09053611296","","");
Order order = new Order("2",3,DateTime.Now.ToString(),"Doing");
IOrderDbAction orderDbAction = new OrderDbAction_Ef();
var result = orderDbAction.OrderChangeStatus(order.OrderCode,"Done");
if(result.Success)
{
    SendSms sendSms = new SendSms(new KavehNegar());
    sendSms.Send("Status Changed",user.Mobile);
}