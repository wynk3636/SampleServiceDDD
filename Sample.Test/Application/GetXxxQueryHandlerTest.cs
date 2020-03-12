using System;
using Xunit;
using Moq;
using AutoMapper;
using Sample.Application.Repository;
using Sample.Application.Query;
using Sample.Domain.Entity;
using Sample.Application.Model;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Test.Application
{
    public class GetXxxQueryHandlerTest
    {
        Mock<IMapper> mapperMock = new Mock<IMapper>();
        Mock<IxxxProvider> xxxProvider = new Mock<IxxxProvider>();

        public GetXxxQueryHandlerTest()
        {
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 18, "Adult" };
            yield return new object[] { 17, "Child" };
        }

        [Fact]
        public async Task Over18Async()
        {
            xxxProvider.Setup(x => x.GetXxxEntity(It.IsAny<GetXxxQuery>()))
                .ReturnsAsync(new xxxEntity { age=18 });

            GetXxxQueryHandler handler = new GetXxxQueryHandler(mapperMock.Object, xxxProvider.Object);
            xxxDto dto = await handler.Handle(new GetXxxQuery(), new CancellationToken());

            Assert.Equal("Adult", dto.status);
        }

        [Theory(DisplayName = "multipleTest"),
            MemberData(nameof(GetData))]
        public async Task ageAsync(int _age, String expectedStatus)
        {
            xxxProvider.Setup(x => x.GetXxxEntity(It.IsAny<GetXxxQuery>()))
                .ReturnsAsync(new xxxEntity { age = _age });

            GetXxxQueryHandler handler = new GetXxxQueryHandler(mapperMock.Object, xxxProvider.Object);
            xxxDto dto = await handler.Handle(new GetXxxQuery(), new CancellationToken());

            Assert.Equal(expectedStatus, dto.status);
        }
    }
}
