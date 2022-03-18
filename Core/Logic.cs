using Core.Services;

namespace Core;

public partial class Logic {
   public Logic(IDataService data, IAuthenticationService authentication, IEncryptionService encryption) {
      Data = data;
      Authentication = authentication;
      Encryption = encryption;
   }

   readonly IDataService Data;
   readonly IAuthenticationService Authentication;
   readonly IEncryptionService Encryption;
}