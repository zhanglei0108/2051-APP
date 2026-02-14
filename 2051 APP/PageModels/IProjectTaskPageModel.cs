using _2051_APP.Models;
using CommunityToolkit.Mvvm.Input;

namespace _2051_APP.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}