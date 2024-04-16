namespace LibraryManagement;
interface INotificationService {
    public void SendNotificationOnSucess(String message) ;
    public void SendNotificationOnFailure(String errorMessage);
}