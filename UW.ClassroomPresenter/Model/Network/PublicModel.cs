// $Id: PublicModel.cs 1043 2006-07-19 22:48:12Z julenka $

using System;

namespace UW.ClassroomPresenter.Model.Network {
    [Serializable]
    public class PublicModel : RoleModel {
        public PublicModel(Guid id) : base(id) {
        }
    }
}
