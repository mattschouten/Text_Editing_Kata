using System.Collections.Generic;
using FluentAssertions;
using ProductionCode.Models;
using Xunit;
using static ProductionCode.ClaimValueGenerator;

namespace ProductionCodeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateUserRecordWithClaims()
        {
            Dictionary<string, string> userClaims = null;
            var actual = new UserRecord()
            {
                Name = ClaimValue(userClaims, "name"),
                EmailAddress = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"),
                UserId = ClaimValue(userClaims, "My User ID"),
                FirstName = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"),
                LastName = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")
            };

            actual.Name.Should().Contain("name");
            actual.EmailAddress.Should().Contain("claims/emailaddress");
            actual.UserId.Should().Contain("My User ID");
            actual.FirstName.Should().Contain("claims/givenname");
            actual.LastName.Should().Contain("claims/surname");
        }

        [Fact]
        public void CanCreateUserRecordWithNullClaims()
        {
            Dictionary<string, string> userClaims = null;
            var actual = new UserRecord()
            {
                Name = ClaimValue(userClaims, "name"),
                EmailAddress = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"),
                UserId = ClaimValue(userClaims, "My User ID"),
                FirstName = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"),
                LastName = ClaimValue(userClaims, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")
            };

            actual.Name.Should().BeNull();
            actual.EmailAddress.Should().BeNull();
            actual.UserId.Should().BeNull();
            actual.FirstName.Should().BeNull();
            actual.LastName.Should().BeNull();
        }

        // TODO:  Should include a test for values being set without using ClaimValue!!!.  Totally can't believe I left out that super important test!
    }
}
