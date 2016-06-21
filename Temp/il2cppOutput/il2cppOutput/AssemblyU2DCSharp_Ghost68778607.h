#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t284553113;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Ghost
struct  Ghost_t68778607  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Transform Ghost::target
	Transform_t284553113 * ___target_2;
	// System.Single Ghost::speed
	float ___speed_3;
	// System.Single Ghost::attack1Range
	float ___attack1Range_4;
	// System.Int32 Ghost::attack1Damage
	int32_t ___attack1Damage_5;
	// System.Single Ghost::timeBetweenAttacks
	float ___timeBetweenAttacks_6;
	// System.Int32 Ghost::start
	int32_t ___start_7;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___target_2)); }
	inline Transform_t284553113 * get_target_2() const { return ___target_2; }
	inline Transform_t284553113 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(Transform_t284553113 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}

	inline static int32_t get_offset_of_speed_3() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___speed_3)); }
	inline float get_speed_3() const { return ___speed_3; }
	inline float* get_address_of_speed_3() { return &___speed_3; }
	inline void set_speed_3(float value)
	{
		___speed_3 = value;
	}

	inline static int32_t get_offset_of_attack1Range_4() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___attack1Range_4)); }
	inline float get_attack1Range_4() const { return ___attack1Range_4; }
	inline float* get_address_of_attack1Range_4() { return &___attack1Range_4; }
	inline void set_attack1Range_4(float value)
	{
		___attack1Range_4 = value;
	}

	inline static int32_t get_offset_of_attack1Damage_5() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___attack1Damage_5)); }
	inline int32_t get_attack1Damage_5() const { return ___attack1Damage_5; }
	inline int32_t* get_address_of_attack1Damage_5() { return &___attack1Damage_5; }
	inline void set_attack1Damage_5(int32_t value)
	{
		___attack1Damage_5 = value;
	}

	inline static int32_t get_offset_of_timeBetweenAttacks_6() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___timeBetweenAttacks_6)); }
	inline float get_timeBetweenAttacks_6() const { return ___timeBetweenAttacks_6; }
	inline float* get_address_of_timeBetweenAttacks_6() { return &___timeBetweenAttacks_6; }
	inline void set_timeBetweenAttacks_6(float value)
	{
		___timeBetweenAttacks_6 = value;
	}

	inline static int32_t get_offset_of_start_7() { return static_cast<int32_t>(offsetof(Ghost_t68778607, ___start_7)); }
	inline int32_t get_start_7() const { return ___start_7; }
	inline int32_t* get_address_of_start_7() { return &___start_7; }
	inline void set_start_7(int32_t value)
	{
		___start_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
