using ParanoiaCharacterGenerator;
using Shouldly;
namespace ParanoiaCharacterGenerator.Tests;

public class Character_should
{
    [Fact]
    public void default_skill_to_zero()
    {
        ICharacter subject = new Character();
        subject.GetSkill(SkillTypes.AlphaComplex).ShouldBe(0);
    }
}