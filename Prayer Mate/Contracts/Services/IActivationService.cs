namespace Prayer_Mate.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
