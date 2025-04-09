using AlexaVoxCraft.MediatR.Lambda;
using AlexaVoxCraft.Model.Apl;
using Sample.Apl.Function;

APLSupport.Add();
return await LambdaHostExtensions.RunAlexaSkill<Function>();