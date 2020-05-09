using raketero_xamarin.Helpers;
using raketero_xamarin.Models;
using raketero_xamarin.Services.Concrete;
using raketero_xamarin.Services.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.ViewModels
{
    public interface IAddJobProfileViewModel
    {
        void AddProfile();
    }

    public class AddJobProfileViewModel : ViewModelBase, IAddJobProfileViewModel
    {
        public bool IsBusy { get; set; } = false;
        public string LoadingMessage { get; set; }
        public AddJobProfileModelDTO AddJobProfileModel { get; set; }
        public override string ScreenName { get; set; } = "AddJobProfile";
        public IViewModelNavigator ViewModelNavigator { get; }
        public IProfileRepository ProfileRepository { get; }

        public JobModel SelectedJob { get; set; } = new JobModel();
        public ObservableCollection<JobModel> JobList { get; set; } = new ObservableCollection<JobModel>();

        public AddJobProfileViewModel(IViewModelNavigator viewModelNavigator, IProfileRepository profileRepository)
        {
            ViewModelNavigator = viewModelNavigator;
            ProfileRepository = profileRepository;
            AddJobProfileModel = new AddJobProfileModelDTO();

            JobList.Add(new JobModel { Id = 1, Name = "House Fixes", Description = "Includes plumbing work, electrical, cleaing, renovation." });
            JobList.Add(new JobModel { Id = 2, Name = "Grooming", Description = "Includes manicure, pedicure, massage, haircuts" });
            JobList.Add(new JobModel { Id = 3, Name = "Construction", Description = "House building, metal works, wood works" });
            JobList.Add(new JobModel { Id = 4, Name = "Entertainment", Description = "Includes Party needs, singers, photographers" });
            JobList.Add(new JobModel { Id = 5, Name = "Modeling", Description = "For product commercials" });
            JobList.Add(new JobModel { Id = 6, Name = "Promotional", Description = "Selling stuff" });

        }

        public void AddProfile()
        {
            IsBusy = true;
            ProfileRepository.AddJobProfile(new AddJobProfileModelDTO
            {
                End_date = AddJobProfileModel.End_date,
                Id_user = 1,
                Job_title = AddJobProfileModel.Job_title,
                Is_current_job = true,
                Start_date = AddJobProfileModel.Start_date,
                Id_job = 1,
                Id_image_url = null
            }).ContinueWith(async task =>
            {
                var data = task.Result;

                if (data.responsecode == 1)
                {
                    IsBusy = false;
                    LoadingMessage = "Success";
                    ViewModelNavigator.NavigateToView("Main");
                }
            });
        }



    }
}
