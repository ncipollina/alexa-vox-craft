﻿using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace AlexaVoxCraft.Tests.Fixtures.Attributes;

public class RepromptAutoDataAttribute() : AutoDataAttribute(() =>
{
    var fixture = new Fixture();
    fixture.Customize(new CompositeCustomization(new AutoNSubstituteCustomization()));
    return fixture;
});