namespace VehicleRegistry.Application.DataTransferObjects;

/// <summary>
/// Objeto de transferência de dados de login.
/// </summary>
/// <author>Herberth Leão</author>
/// <email>herberth@leao.sh</email>
public class LoginData : Data
{
    /// <summary>
    /// O e-mail do usuário.
    /// </summary>
    public string Email { get; set; } = "";

    /// <summary>
    /// A senha do usuário.
    /// </summary>
    public string Password { get; set; } = "";
}