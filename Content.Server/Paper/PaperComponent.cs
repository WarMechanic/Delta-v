using Content.Shared.Paper;
using Robust.Shared.GameStates;

namespace Content.Server.Paper;

[RegisterComponent]
public sealed partial class PaperComponent : SharedPaperComponent
{
    public PaperAction Mode;
    [DataField("content")]
    public string Content { get; set; } = "";

    [DataField("contentSize")]
    public int ContentSize { get; set; } = 6000;

    [DataField("stampedBy")]
    public List<StampDisplayInfo> StampedBy { get; set; } = new();

    [DataField("canEdit")]
    [ViewVariables(VVAccess.ReadWrite)]
    public bool CanEdit { get; set; } = true; // DeltaV - Used for paper slips

    /// <summary>
    ///     Stamp to be displayed on the paper, state from beauracracy.rsi
    /// </summary>
    [DataField("stampState")]
    public string? StampState { get; set; }
}
