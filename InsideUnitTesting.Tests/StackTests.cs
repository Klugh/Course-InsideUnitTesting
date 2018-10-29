﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InsideUnitTesting.UnitTests
{
	public class StackTests : IDisposable
	{
		Stack<int> stack;

		public StackTests()
		{
			stack = new Stack<int>();
		}

		public void Dispose()
		{

		}

		[Fact]
		public void WithNoItems_CountShouldReturnZero()
		{
			var count = stack.Count;

			Assert.Equal(0, count);
		}

		[Fact]
		public void AfterPushingItem_CountShouldReturnOne()
		{
			stack.Push(42);

			var count = stack.Count;

			Assert.Equal(1, count);
		}
	}
}