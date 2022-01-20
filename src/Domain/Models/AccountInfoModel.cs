using MongoDbGenericRepository.Attributes;

namespace Domain.Models
{
    [CollectionName("AccountInfo")]
    public class AccountInfoModel
    {
        public string Avatar { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
