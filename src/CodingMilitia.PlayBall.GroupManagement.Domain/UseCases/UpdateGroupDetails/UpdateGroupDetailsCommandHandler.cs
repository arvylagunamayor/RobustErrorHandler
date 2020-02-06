using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CodingMilitia.PlayBall.GroupManagement.Domain.Data;
using CodingMilitia.PlayBall.GroupManagement.Domain.Data.Queries;
using CodingMilitia.PlayBall.GroupManagement.Domain.Entities;
using MediatR;

namespace CodingMilitia.PlayBall.GroupManagement.Domain.UseCases.UpdateGroupDetails
{
    public sealed class UpdateGroupDetailsCommandHandler
        : IRequestHandler<UpdateGroupDetailsCommand, UpdateGroupDetailsCommandResult>
    {
        private readonly IQueryHandler<UserByIdQuery, User> _userByIdQueryHandler;
        private readonly IQueryHandler<UserGroupQuery, Group> _userGroupQueryHandler;
        private readonly IVersionedRepository<Group, uint> _groupsRepository;

        public UpdateGroupDetailsCommandHandler(
            IQueryHandler<UserByIdQuery, User> userByIdQueryHandler,
            IQueryHandler<UserGroupQuery, Group> userGroupQueryHandler,
            IVersionedRepository<Group, uint> groupsRepository)
        {
            _userByIdQueryHandler =
                userByIdQueryHandler ?? throw new ArgumentNullException(nameof(userByIdQueryHandler));
            _userGroupQueryHandler =
                userGroupQueryHandler ?? throw new ArgumentNullException(nameof(userGroupQueryHandler));
            _groupsRepository = groupsRepository ?? throw new ArgumentNullException(nameof(groupsRepository));
        }

        public async Task<UpdateGroupDetailsCommandResult> Handle(
            UpdateGroupDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var group = await _userGroupQueryHandler.HandleAsync(
                new UserGroupQuery(request.UserId, request.GroupId),
                cancellationToken);

            if (group is null)
            {
                return null;
            }

            var currentUser = await _userByIdQueryHandler.HandleAsync(
                new UserByIdQuery(request.UserId),
                cancellationToken);

            group.Rename(currentUser, request.Name);

            await _groupsRepository.UpdateAsync(group, uint.Parse(request.RowVersion), cancellationToken);

            return new UpdateGroupDetailsCommandResult(
                group.Id,
                group.Name,
                group.RowVersion.ToString());
        }
    }
}