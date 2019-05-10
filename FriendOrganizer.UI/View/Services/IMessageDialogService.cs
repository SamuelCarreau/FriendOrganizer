using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;

namespace FriendOrganizer.UI.View.Services
{
    public interface IMessageDialogService
    {
        Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title);
        Task ShowInfoDialogAsync(string text);
    }
}