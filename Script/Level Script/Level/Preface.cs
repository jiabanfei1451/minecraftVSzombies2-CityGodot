using Godot;
using DEBUG;
using System.Threading.Tasks;
namespace Level;
/// <summary>
/// 序章
/// </summary>
public partial class Preface : Level_Master_Script
{
    public override async void _Ready() {
        base._Ready();
        Game.WindowTool.Set_Title("114514");
        choose_Card();
        MVZ2_City.Object_List list = Game.Get_GlobalNode.object_List; 
        await ToSignal(GetTree().CreateTimer(6),SceneTreeTimer.SignalName.Timeout);
        Summand.Add_wave(new System.Collections.Generic.List<MVZ2_City.Type.ID>(){list.Get_ID("0")},1,10,true);
        Summand._Ready();
        for(int i = 0;i < 5;i++){
        Summand.Summand_Object(list.Get_ID("0"));
        await Task.Delay(10);
        }
    }
}
