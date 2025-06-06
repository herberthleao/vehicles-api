using Microsoft.AspNetCore.Identity;

namespace VehicleRegistry.Domain.Entities;

/// <summary>
/// Entidade de usuário.
/// </summary>
/// <author>Herberth Leão</author>
/// <email>herberth@leao.sh</email>
public class User : IdentityUser, IEntity
{
    /// <summary>
    /// A data de registro do usuário.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// A data de atualização de registro do usuário.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}