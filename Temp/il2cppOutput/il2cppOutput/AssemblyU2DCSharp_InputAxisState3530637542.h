#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String
struct String_t;

#include "mscorlib_System_Object837106420.h"
#include "AssemblyU2DCSharp_Buttons1906005857.h"
#include "AssemblyU2DCSharp_Condition1142656251.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// InputAxisState
struct  InputAxisState_t3530637542  : public Il2CppObject
{
public:
	// System.String InputAxisState::axisName
	String_t* ___axisName_0;
	// System.Single InputAxisState::offValue
	float ___offValue_1;
	// Buttons InputAxisState::button
	int32_t ___button_2;
	// Condition InputAxisState::condition
	int32_t ___condition_3;

public:
	inline static int32_t get_offset_of_axisName_0() { return static_cast<int32_t>(offsetof(InputAxisState_t3530637542, ___axisName_0)); }
	inline String_t* get_axisName_0() const { return ___axisName_0; }
	inline String_t** get_address_of_axisName_0() { return &___axisName_0; }
	inline void set_axisName_0(String_t* value)
	{
		___axisName_0 = value;
		Il2CppCodeGenWriteBarrier(&___axisName_0, value);
	}

	inline static int32_t get_offset_of_offValue_1() { return static_cast<int32_t>(offsetof(InputAxisState_t3530637542, ___offValue_1)); }
	inline float get_offValue_1() const { return ___offValue_1; }
	inline float* get_address_of_offValue_1() { return &___offValue_1; }
	inline void set_offValue_1(float value)
	{
		___offValue_1 = value;
	}

	inline static int32_t get_offset_of_button_2() { return static_cast<int32_t>(offsetof(InputAxisState_t3530637542, ___button_2)); }
	inline int32_t get_button_2() const { return ___button_2; }
	inline int32_t* get_address_of_button_2() { return &___button_2; }
	inline void set_button_2(int32_t value)
	{
		___button_2 = value;
	}

	inline static int32_t get_offset_of_condition_3() { return static_cast<int32_t>(offsetof(InputAxisState_t3530637542, ___condition_3)); }
	inline int32_t get_condition_3() const { return ___condition_3; }
	inline int32_t* get_address_of_condition_3() { return &___condition_3; }
	inline void set_condition_3(int32_t value)
	{
		___condition_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
