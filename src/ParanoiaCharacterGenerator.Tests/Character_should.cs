using ParanoiaCharacterGenerator;
using Shouldly;
namespace ParanoiaCharacterGenerator.Tests;

public class Character_should
{
    [Theory]
    [InlineData(SkillTypes.AlphaComplex)]
    public void default_skill_to_zero(SkillTypes skillType)
    {
        ICharacter subject = new Character();
        subject.GetSkill(skillType).ShouldBe(0);
    }
}