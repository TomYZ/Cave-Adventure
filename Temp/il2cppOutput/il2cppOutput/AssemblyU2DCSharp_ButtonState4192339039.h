#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "mscorlib_System_Object837106420.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ButtonState
struct  ButtonState_t4192339040  : public Il2CppObject
{
public:
	// System.Boolean ButtonState::value
	bool ___value_0;
	// System.Single ButtonState::holdTime
	float ___holdTime_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(ButtonState_t4192339040, ___value_0)); }
	inline bool get_value_0() const { return ___value_0; }
	inline bool* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(bool value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_holdTime_1() { return static_cast<int32_t>(offsetof(ButtonState_t4192339040, ___holdTime_1)); }
	inline float get_holdTime_1() const { return ___holdTime_1; }
	inline float* get_address_of_holdTime_1() { return &___holdTime_1; }
	inline void set_holdTime_1(float value)
	{
		___holdTime_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
