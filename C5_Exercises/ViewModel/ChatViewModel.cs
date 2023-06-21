using C5_Exercises.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C5_Exercises.ViewModel
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private ChatModel _chatModel;
        private ChatDataModel _selectedChatModel;
        private ObservableCollection<ChatDataModel> _chats;
        private ObservableCollection<Message> _messageList;

        public ObservableCollection<ChatDataModel> ChatCategoryList { get => _chats; set { _chats = value;OnPropertyChanged(); } }
        public ChatDataModel ChatModel { get=> _selectedChatModel; set { _selectedChatModel = value; OnPropertyChanged(); } }

        public ObservableCollection<Message> ShowMessageList { get => _messageList; set { _messageList = value; OnPropertyChanged(); } }
          
        public ICommand ShowSelecteCategory { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ChatViewModel()
        {
            ShowSelecteCategory = new Command(GetSlectedCategory);
            _chatModel = new ChatModel();
            _chatModel.GetCategoryList();
            ChatCategoryList = _chatModel.Chats; 
            ChatModel = _chatModel.SelectedChatModel;
            ShowMessageList = _chatModel.ShowMessageList;
        }

        private void GetSlectedCategory()
        {
            _chatModel.SelectedChatModel = ChatModel;
            _chatModel.GetCategoryList();
            ShowMessageList = _chatModel.ShowMessageList;
        }
        
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
