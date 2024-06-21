using ParanoiaCharacterGenerator;
using Shouldly;
namespace ParanoiaCharacterGenerator.Tests;

public class Character_should
{
    [Theory]
    [InlineData(SkillTypes.AlphaComplex)]
    [InlineData(SkillTypes.Bureaucracy)]
    [InlineData(SkillTypes.Psychology)]
    [InlineData(SkillTypes.Science)]
    [InlineData(SkillTypes.Bluff)]
    [InlineData(SkillTypes.Charm)]
    [InlineData(SkillTypes.Intimidate)]
    [InlineData(SkillTypes.Stealth)]
    [InlineData(SkillTypes.Demolition)]
    [InlineData(SkillTypes.Engineer)]
    [InlineData(SkillTypes.Operate)]
    [InlineData(SkillTypes.Program)]
    [InlineData(SkillTypes.Athletics)]
    [InlineData(SkillTypes.Guns)]
    [InlineData(SkillTypes.Melee)]
    [InlineData(SkillTypes.Throw)]
    public void default_skill_to_zero(SkillTypes skillType)
    {
        ICharacter subject = new Character();
        subject.GetSkill(skillType).ShouldBe(0);
    }
}