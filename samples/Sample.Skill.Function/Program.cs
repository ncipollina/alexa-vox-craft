using AlexaVoxCraft.MediatR.Lambda;
using AlexaVoxCraft.MediatR.Lambda.Extensions;
using Sample.Skill.Function;

return await LambdaHostExtensions.RunAlexaSkill<Function>();