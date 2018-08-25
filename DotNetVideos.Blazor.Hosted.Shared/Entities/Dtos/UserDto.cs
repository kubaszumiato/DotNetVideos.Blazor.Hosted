using System;

namespace DotNetVideos.Blazor.Hosted.Shared.Entities.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}