using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Model.Entities;

namespace iut
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICommandService
    {
        [OperationContract]
        List<Command> GetAllCommands();

        [OperationContract]
        Command GetCommand(int id);
    }
}
