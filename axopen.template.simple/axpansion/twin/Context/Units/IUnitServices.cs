// axosimple
// Copyright (c)2024 Peter Kurhajec and Contributors All Rights Reserved.
// Contributors: https://github.com/PTKu/ix/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/PTKu/ix/blob/master/LICENSE
// Third party licenses: https://github.com/PTKu/ix/blob/master/notices.md

using AXOpen.Messaging.Static;
using AXSharp.Connector;

namespace axosimple.server.Units;

public interface IUnitServices
{
    public string Link => "Context/UnitTemplate";

    public string ImageLink => "logo-header.svg";
}