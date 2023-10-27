// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

namespace CoreWidgetProvider.Widgets.Enums;
public enum WidgetActivityState
{
    /// <summary>
    /// Error state and default initialization. This state is a clue something went terribly wrong.
    /// </summary>
    Unknown,

    /// <summary>
    /// Widget is in this state after it is created before it has data assigned to it and before it
    /// is pinned. It can also reach this state if the user chose to Customize the widget.
    /// </summary>
    Configure,

    /// <summary>
    /// Widget is configured, pinned, and it is assumed user can interact and see it.
    /// </summary>
    Active,

    /// <summary>
    /// Widget is in good state, but host is minimized or disables the widget.
    /// </summary>
    Inactive,
}
