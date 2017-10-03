﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄████████
      █     ███    ███
      █     ███    █▀     ▄█████  ▄██████ ██   █     █████  █      ██    ▄█   ▄
      █     ███          ██   █  ██    ██ ██   ██   ██  ██ ██  ▀███████▄ ██   █▄
      █   ▀███████████  ▄██▄▄    ██    ▀  ██   ██  ▄██▄▄█▀ ██▌     ██  ▀ ▀▀▀▀▀██
      █            ███ ▀▀██▀▀    ██    ▄  ██   ██ ▀███████ ██      ██    ▄█   ██
      █      ▄█    ███   ██   █  ██    ██ ██   ██   ██  ██ ██      ██    ██   ██
      █    ▄████████▀    ███████ ██████▀  ██████    ██  ██ █      ▄██▀    █████
      █
      █   ▄████████
      █   ███    ███
      █   ███    █▀   ██████  ██▄▄▄▄      ██       █████  ██████   █        █          ▄█████    █████
      █   ███        ██    ██ ██▀▀▀█▄ ▀███████▄   ██  ██ ██    ██ ██       ██         ██   █    ██  ██
      █   ███        ██    ██ ██   ██     ██  ▀  ▄██▄▄█▀ ██    ██ ██       ██        ▄██▄▄     ▄██▄▄█▀
      █   ███    █▄  ██    ██ ██   ██     ██    ▀███████ ██    ██ ██       ██       ▀▀██▀▀    ▀███████
      █   ███    ███ ██    ██ ██   ██     ██      ██  ██ ██    ██ ██▌    ▄ ██▌    ▄   ██   █    ██  ██
      █   ████████▀   ██████   █   █     ▄██▀     ██  ██  ██████  ████▄▄██ ████▄▄██   ███████   ██  ██
      █
      █       ███
      █   ▀█████████▄
      █      ▀███▀▀██    ▄█████   ▄█████     ██      ▄█████
      █       ███   ▀   ██   █    ██  ▀  ▀███████▄   ██  ▀
      █       ███      ▄██▄▄      ██         ██  ▀   ██
      █       ███     ▀▀██▀▀    ▀███████     ██    ▀███████
      █       ███       ██   █     ▄  ██     ██       ▄  ██
      █      ▄████▀     ███████  ▄████▀     ▄██▀    ▄████▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Unit tests for the SecurityController class.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Moq;
using OpenIIoT.SDK;
using OpenIIoT.SDK.Security;
using Utility.OperationResult;
using Xunit;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace OpenIIoT.Core.Tests.Security.WebApi
{
    /// <summary>
    ///     Unit tests for the <see cref="Core.Security.WebApi.SecurityController"/> class.
    /// </summary>
    [Collection("SecurityController")]
    public class SecurityController
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SecurityController"/> class.
        /// </summary>
        public SecurityController()
        {
            SecurityManager = new Mock<ISecurityManager>();

            Manager = new Mock<IApplicationManager>();
            Manager.Setup(m => m.GetManager<ISecurityManager>()).Returns(SecurityManager.Object);

            Controller = new Core.Security.WebApi.SecurityController(Manager.Object);
            Controller.Request = new HttpRequestMessage();
            Controller.Configuration = new HttpConfiguration();

            User = new SDK.Security.User("name", "displayName", "name@test.com", "hash", Role.Reader);
        }

        #endregion Public Constructors

        #region Private Properties

        private SDK.Security.User User { get; set; }

        /// <summary>
        ///     Gets or sets the WebApi Controller under test.
        /// </summary>
        private Core.Security.WebApi.SecurityController Controller { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="IApplicationManager"/> mockup.
        /// </summary>
        private Mock<IApplicationManager> Manager { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="ISecurityManager"/> mockup.
        /// </summary>
        private Mock<ISecurityManager> SecurityManager { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        ///     Tests the constructor.
        /// </summary>
        [Fact]
        public void Constructor()
        {
            Core.Security.WebApi.SecurityController test = new Core.Security.WebApi.SecurityController(Manager.Object);

            Assert.IsType<Core.Security.WebApi.SecurityController>(test);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.RolesGet"/> method.
        /// </summary>
        [Fact]
        public void RolesGet()
        {
            SecurityManager.Setup(s => s.Roles).Returns(new[] { Role.Reader, Role.ReadWriter, Role.Administrator }.ToList());

            HttpResponseMessage response = Controller.RolesGet();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            IReadOnlyList<Role> roles = response.GetContent<IReadOnlyList<Role>>();

            Assert.NotEmpty(roles);
            Assert.Contains(Role.Reader, roles);
            Assert.Contains(Role.ReadWriter, roles);
            Assert.Contains(Role.Administrator, roles);

            SecurityManager.Verify(s => s.Roles, Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsEnd"/> method.
        /// </summary>
        [Fact]
        public void SessionsEnd()
        {
            SecurityManager.Setup(s => s.FindSession(It.IsAny<string>())).Returns(new Session(User, null));
            SecurityManager.Setup(s => s.EndSession(It.IsAny<Session>())).Returns(new Result());

            HttpResponseMessage response = Controller.SessionsEnd();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            SecurityManager.Verify(s => s.FindSession(It.IsAny<string>()), Times.Once);
            SecurityManager.Verify(s => s.EndSession(It.IsAny<Session>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsEnd"/> method with an
        ///     <see cref="ISecurityManager"/> returning a failing result.
        /// </summary>
        [Fact]
        public void SessionsEndFailure()
        {
            SecurityManager.Setup(s => s.FindSession(It.IsAny<string>())).Returns(new Session(User, null));
            SecurityManager.Setup(s => s.EndSession(It.IsAny<Session>())).Returns(new Result(ResultCode.Failure));

            HttpResponseMessage response = Controller.SessionsEnd();

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            Assert.Equal(ResultCode.Failure, response.GetContent<IResult>().ResultCode);

            SecurityManager.Verify(s => s.FindSession(It.IsAny<string>()), Times.Once);
            SecurityManager.Verify(s => s.EndSession(It.IsAny<Session>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsGet"/> method.
        /// </summary>
        [Fact]
        public void SessionsGet()
        {
            SDK.Security.Ticket ticket = new SDK.Security.Ticket(new ClaimsIdentity());
            ticket.Identity.AddClaim(new Claim(ClaimTypes.Hash, "key"));

            SecurityManager.Setup(s => s.Sessions).Returns(new[] { new Session(User, ticket) }.ToList().AsReadOnly());

            HttpResponseMessage response = Controller.SessionsGet();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            IReadOnlyList<Core.Security.WebApi.DTO.SessionData> sessions = response.GetContent<IReadOnlyList<Core.Security.WebApi.DTO.SessionData>>();

            Assert.NotEmpty(sessions);
            Assert.Equal("key", sessions[0].Token);

            SecurityManager.Verify(s => s.Sessions, Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsGetCurrent"/> method.
        /// </summary>
        [Fact]
        public void SessionsGetCurrent()
        {
            SDK.Security.Ticket ticket = new SDK.Security.Ticket(new ClaimsIdentity());
            ticket.Identity.AddClaim(new Claim(ClaimTypes.Hash, "key"));

            SecurityManager.Setup(s => s.FindSession(It.IsAny<string>())).Returns(new Session(User, ticket));

            HttpResponseMessage response = Controller.SessionsGetCurrent();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("key", response.GetContent<Core.Security.WebApi.DTO.SessionData>().Token);

            SecurityManager.Verify(s => s.FindSession(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsStart(string, string)"/> method.
        /// </summary>
        [Fact]
        public void SessionsStart()
        {
            SDK.Security.Ticket ticket = new SDK.Security.Ticket(new ClaimsIdentity());
            ticket.Identity.AddClaim(new Claim(ClaimTypes.Hash, "key"));

            SecurityManager.Setup(s => s.StartSession(It.IsAny<string>(), It.IsAny<string>())).Returns(new Result<Session>().SetReturnValue(new Session(User, ticket)));

            HttpResponseMessage response = Controller.SessionsStart(new Core.Security.WebApi.DTO.SessionStartData() { Name = "user", Password = "password" });

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("key", response.GetContent<Core.Security.WebApi.DTO.SessionData>().Token);

            SecurityManager.Verify(s => s.StartSession(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsStart(string, string)"/> method with a known
        ///     bad password.
        /// </summary>
        [Fact]
        public void SessionsStartBadPassword()
        {
            HttpResponseMessage response = Controller.SessionsStart(new Core.Security.WebApi.DTO.SessionStartData() { Name = "user", Password = string.Empty });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsStart(string, string)"/> method with a known
        ///     bad user.
        /// </summary>
        [Fact]
        public void SessionsStartBadUser()
        {
            HttpResponseMessage response = Controller.SessionsStart(new Core.Security.WebApi.DTO.SessionStartData() { Name = string.Empty, Password = "password" });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.SessionsStart(string, string)"/> method with an
        ///     <see cref="ISecurityManager"/> returning a failing result.
        /// </summary>
        [Fact]
        public void SessionsStartFailure()
        {
            SecurityManager.Setup(s => s.StartSession(It.IsAny<string>(), It.IsAny<string>())).Returns(new Result<Session>(ResultCode.Failure));

            HttpResponseMessage response = Controller.SessionsStart(new Core.Security.WebApi.DTO.SessionStartData() { Name = "user", Password = "password" });

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
            Assert.Equal(ResultCode.Failure, response.GetContent<IResult>().ResultCode);

            SecurityManager.Verify(s => s.StartSession(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersCreate(string, string, Role)"/> method.
        /// </summary>
        [Fact]
        public void UsersCreate()
        {
            string hash = "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86";
            SDK.Security.User user = new User("user", "user", "test@test.com", hash, Role.Reader);

            SecurityManager.Setup(s => s.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role>())).Returns(new Result<User>().SetReturnValue(user));

            HttpResponseMessage response = Controller.UsersCreate(new Core.Security.WebApi.DTO.UserCreateData() { Name = "user", DisplayName = "name", Email = "test@test.com", Password = "password", Role = Role.Reader });

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);

            Core.Security.WebApi.DTO.UserData responseUser = response.GetContent<Core.Security.WebApi.DTO.UserData>();

            Assert.Equal("user", responseUser.Name);
            Assert.Equal(Role.Reader, responseUser.Role);

            SecurityManager.Verify(s => s.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role>()), Times.Once());
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersCreate(string, string, Role)"/> method with a
        ///     known bad password.
        /// </summary>
        [Fact]
        public void UsersCreateBadPassword()
        {
            HttpResponseMessage response = Controller.UsersCreate(new Core.Security.WebApi.DTO.UserCreateData() { Name = "user", Password = string.Empty, Role = Role.Reader });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersCreate(string, string, Role)"/> method with a
        ///     known bad user name.
        /// </summary>
        [Fact]
        public void UsersCreateBadUser()
        {
            HttpResponseMessage response = Controller.UsersCreate(new Core.Security.WebApi.DTO.UserCreateData() { Name = string.Empty, DisplayName = "name", Email = "test@test.com", Password = "password", Role = Role.Reader });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersCreate(string, string, Role)"/> method with
        ///     <see cref="ISecurityManager"/> returning a failing result.
        /// </summary>
        [Fact]
        public void UsersCreateFailure()
        {
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(default(SDK.Security.User));
            SecurityManager.Setup(s => s.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role>())).Returns(new Result<User>(ResultCode.Failure));

            Core.Security.WebApi.DTO.UserCreateData newUser = new Core.Security.WebApi.DTO.UserCreateData() { Name = "user", DisplayName = "name", Email = "test@test.com", Password = "password", Role = Role.Reader };
            HttpResponseMessage response = Controller.UsersCreate(newUser);

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            Assert.Equal(ResultCode.Failure, response.GetContent<IResult>().ResultCode);

            SecurityManager.Verify(s => s.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersCreate(string, string, Role)"/> method with an
        ///     existing user.
        /// </summary>
        [Fact]
        public void UsersCreateUserExists()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);

            HttpResponseMessage response = Controller.UsersCreate(new Core.Security.WebApi.DTO.UserCreateData() { Name = "user", DisplayName = "name", Email = "test@test.com", Password = "password", Role = Role.Reader });

            Assert.Equal(HttpStatusCode.Conflict, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersDelete(string)"/> method.
        /// </summary>
        [Fact]
        public void UsersDelete()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.DeleteUser(It.IsAny<string>())).Returns(new Result());

            HttpResponseMessage response = Controller.UsersDelete("user");

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);

            SecurityManager.Verify(s => s.FindUser(It.IsAny<string>()), Times.Once);
            SecurityManager.Verify(s => s.DeleteUser(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersDelete(string)"/> method with a known bad user name.
        /// </summary>
        [Fact]
        public void UsersDeleteBadUser()
        {
            HttpResponseMessage response = Controller.UsersDelete(string.Empty);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersDelete(string)"/> method with
        ///     <see cref="ISecurityManager"/> returning a failing result.
        /// </summary>
        [Fact]
        public void UsersDeleteFailure()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.DeleteUser(It.IsAny<string>())).Returns(new Result(ResultCode.Failure));

            HttpResponseMessage response = Controller.UsersDelete("user");

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            Assert.Equal(ResultCode.Failure, response.GetContent<IResult>().ResultCode);

            SecurityManager.Verify(s => s.FindUser(It.IsAny<string>()), Times.Once);
            SecurityManager.Verify(s => s.DeleteUser(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersDelete(string)"/> method with a user which is not found.
        /// </summary>
        [Fact]
        public void UsersDeleteUserNotFound()
        {
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(default(User));

            HttpResponseMessage response = Controller.UsersDelete("user");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            SecurityManager.Verify(s => s.FindUser(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersGet"/> method.
        /// </summary>
        [Fact]
        public void UsersGet()
        {
            SecurityManager.Setup(s => s.Users).Returns(new[] { new User("user", "user", "test@test.com", "hash", Role.Reader) }.ToList().AsReadOnly());

            HttpResponseMessage response = Controller.UsersGet();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            IReadOnlyList<Core.Security.WebApi.DTO.UserData> users = response.GetContent<IReadOnlyList<Core.Security.WebApi.DTO.UserData>>();

            Assert.NotEmpty(users);
            Assert.Equal("user", users[0].Name);
            Assert.Equal(Role.Reader, users[0].Role);

            SecurityManager.Verify(s => s.Users, Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersGetName(string)"/> method.
        /// </summary>
        [Fact]
        public void UsersGetName()
        {
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(new User("user", "user", "test@test.com", "hash", Role.Reader));

            HttpResponseMessage response = Controller.UsersGetName("user");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("user", response.GetContent<Core.Security.WebApi.DTO.UserData>().Name);

            SecurityManager.Verify(s => s.FindUser(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersGetName(string)"/> method with a known bad name.
        /// </summary>
        [Fact]
        public void UsersGetNameBadName()
        {
            HttpResponseMessage response = Controller.UsersGetName(string.Empty);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            SecurityManager.Verify(s => s.Users, Times.Never);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersGetName(string)"/> method with a User which can
        ///     not be found.
        /// </summary>
        [Fact]
        public void UsersGetNameNotFound()
        {
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(default(User));

            HttpResponseMessage response = Controller.UsersGetName(Guid.NewGuid().ToString());

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            SecurityManager.Verify(s => s.FindUser(It.IsAny<string>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method.
        /// </summary>
        [Fact]
        public void UsersUpdate()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>())).Returns(new Result<User>().SetReturnValue(user));

            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = "newpassword", Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            Core.Security.WebApi.DTO.UserData result = response.GetContent<Core.Security.WebApi.DTO.UserData>();

            Assert.Equal(user.Name, result.Name);
            Assert.Equal(user.Role, result.Role);

            SecurityManager.Verify(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with a
        ///     known bad password.
        /// </summary>
        [Fact]
        public void UsersUpdateBadPassword()
        {
            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = string.Empty, Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with a
        ///     known bad user.
        /// </summary>
        [Fact]
        public void UsersUpdateBadUser()
        {
            HttpResponseMessage response = Controller.UsersUpdate(string.Empty, new Core.Security.WebApi.DTO.UserUpdateData() { Password = "newpassword", Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with an
        ///     <see cref="ISecurityManager"/> returning a failing result.
        /// </summary>
        [Fact]
        public void UsersUpdateFailure()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>())).Returns(new Result<User>(ResultCode.Failure));

            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = "newpassword", Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

            IResult result = response.GetContent<Result>(); // failures downcast generic Results

            Assert.Equal(ResultCode.Failure, result.ResultCode);

            SecurityManager.Verify(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with
        ///     neither an updated <see cref="Role"/> nor password.
        /// </summary>
        [Fact]
        public void UsersUpdateNothingToUpdate()
        {
            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = null, Role = null });

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(string.IsNullOrEmpty(response.GetContent<string>()));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with an
        ///     updated password.
        /// </summary>
        [Fact]
        public void UsersUpdatePassword()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>())).Returns(new Result<User>().SetReturnValue(user));

            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = "newpassword", Role = null });

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            Core.Security.WebApi.DTO.UserData result = response.GetContent<Core.Security.WebApi.DTO.UserData>();

            Assert.Equal(user.Name, result.Name);
            Assert.Equal(user.Role, result.Role);

            SecurityManager.Verify(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with an
        ///     updated <see cref="Role"/>.
        /// </summary>
        [Fact]
        public void UsersUpdateRole()
        {
            SDK.Security.User user = new User("user", "user", "test@test.com", "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86", Role.Reader);
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(user);
            SecurityManager.Setup(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>())).Returns(new Result<User>().SetReturnValue(user));

            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = null, Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            Core.Security.WebApi.DTO.UserData result = response.GetContent<Core.Security.WebApi.DTO.UserData>();

            Assert.Equal(user.Name, result.Name);
            Assert.Equal(user.DisplayName, result.DisplayName);
            Assert.Equal(user.Email, result.Email);
            Assert.Equal(user.Role, result.Role);

            SecurityManager.Verify(s => s.UpdateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Role?>()), Times.Once);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.WebApi.SecurityController.UsersUpdate(string, string, Role?)"/> method with an
        ///     <see cref="ISecurityManager"/> unable to locate the specified user..
        /// </summary>
        [Fact]
        public void UsersUpdateUserNotFound()
        {
            SecurityManager.Setup(s => s.FindUser(It.IsAny<string>())).Returns(default(User));

            HttpResponseMessage response = Controller.UsersUpdate("user", new Core.Security.WebApi.DTO.UserUpdateData() { Password = "newpassword", Role = Role.ReadWriter });

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        #endregion Public Methods
    }
}