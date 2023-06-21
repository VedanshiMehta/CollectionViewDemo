using C5_Exercises.Enum;
using CommunityToolkit.Maui.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.Model
{
     public class ChatModel
    {



        public ChatDataModel SelectedChatModel { get; set; }
        public ObservableCollection<ChatDataModel> Chats { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
        public ObservableCollection<Message> ShowMessageList { get; set; }
       
        public void GetCategoryList()
        {
            Messages = new ObservableCollection<Message>()
            {
                new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},
                 new Message(){ ProfilePhoto = "user2.jpg",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user4.jpg",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "18:00" ,InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2",  Time = "13:50",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user2.jpg",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2",  Time = "11:00",InboxCategoryType = InboxCategoryType.Private},
                new Message(){ ProfilePhoto = "user3.jpg",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "10:20",InboxCategoryType = InboxCategoryType.Group},
                new Message(){ ProfilePhoto = "user5.jpg",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "16:18",InboxCategoryType = InboxCategoryType.Private},

            };

            var totalPrivateMessage = Messages.Where(x => x.InboxCategoryType == InboxCategoryType.Private).Count().ToString();
            var totalGroupMessage = Messages.Where(x => x.InboxCategoryType == InboxCategoryType.Group).Count().ToString();

            Chats = new ObservableCollection<ChatDataModel>()
            {
                new ChatDataModel(){ CategoryName = "Private", TotalChatCount = totalPrivateMessage,InboxCategoryType = InboxCategoryType.Private},
                new ChatDataModel(){ CategoryName = "Group", TotalChatCount = totalGroupMessage,InboxCategoryType = InboxCategoryType.Group}
            };
            if (SelectedChatModel == null)
            {
                SelectedChatModel = Chats.FirstOrDefault();
            }
            ShowMessageList = Messages.Where(x => x.InboxCategoryType == SelectedChatModel.InboxCategoryType).ToObservableCollection();
            
        }
       
    }
    public class ChatDataModel
    {
        public string CategoryName { get; set; }
        public string TotalChatCount { get; set; }

        
        public InboxCategoryType InboxCategoryType { get; set; }
    }
    public class Message
    {
        public ImageSource ProfilePhoto { get; set; }
        public bool IsUnReadMessage { get; set; }  
        
        public string Name { get; set; }
        public string MessageSent { get; set; }
        

        public string UnreadMessage { get; set; }   

        public string Time { get;set; }
        public InboxCategoryType InboxCategoryType { get; set; }
    }
}
