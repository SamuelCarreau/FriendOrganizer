using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace FriendOrganizer.UI.View.Services
{
    public class MessageDialogService : IMessageDialogService
    {
        private MetroWindow MetroWindow => (MetroWindow) App.Current.MainWindow;
    
        public async Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title)
        {
            var result =
                await MetroWindow.ShowMessageAsync(title, text,MessageDialogStyle.AffirmativeAndNegative);

            return result == MessageDialogResult.Affirmative
                ? MessageDialogResult.Affirmative
                : MessageDialogResult.Canceled;
        }

        public async Task ShowInfoDialogAsync(string text)
        {
            await MetroWindow.ShowMessageAsync("Info", text);
        }
    }
    //public enum MessageDialogResult
    //{
    //    OK,
    //    Cancel
    //}

}
