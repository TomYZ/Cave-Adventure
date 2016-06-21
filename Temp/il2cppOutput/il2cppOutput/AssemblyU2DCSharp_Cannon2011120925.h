#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "AssemblyU2DCSharp_AbstractBehavior320735412.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Cannon
struct  Cannon_t2011120925  : public AbstractBehavior_t320735412
{
public:
	// System.Single Cannon::shootDelay
	float ___shootDelay_6;
	// System.Single Cannon::lifetime
	float ___lifetime_7;
	// UnityEngine.GameObject Cannon::projectilePrefab
	GameObject_t4012695102 * ___projectilePrefab_8;
	// System.Single Cannon::timeElapsed
	float ___timeElapsed_9;

public:
	inline static int32_t get_offset_of_shootDelay_6() { return static_cast<int32_t>(offsetof(Cannon_t2011120925, ___shootDelay_6)); }
	inline float get_shootDelay_6() const { return ___shootDelay_6; }
	inline float* get_address_of_shootDelay_6() { return &___shootDelay_6; }
	inline void set_shootDelay_6(float value)
	{
		___shootDelay_6 = value;
	}

	inline static int32_t get_offset_of_lifetime_7() { return static_cast<int32_t>(offsetof(Cannon_t2011120925, ___lifetime_7)); }
	inline float get_lifetime_7() const { return ___lifetime_7; }
	inline float* get_address_of_lifetime_7() { return &___lifetime_7; }
	inline void set_lifetime_7(float value)
	{
		___lifetime_7 = value;
	}

	inline static int32_t get_offset_of_projectilePrefab_8() { return static_cast<int32_t>(offsetof(Cannon_t2011120925, ___projectilePrefab_8)); }
	inline GameObject_t4012695102 * get_projectilePrefab_8() const { return ___projectilePrefab_8; }
	inline GameObject_t4012695102 ** get_address_of_projectilePrefab_8() { return &___projectilePrefab_8; }
	inline void set_projectilePrefab_8(GameObject_t4012695102 * value)
	{
		___projectilePrefab_8 = value;
		Il2CppCodeGenWriteBarrier(&___projectilePrefab_8, value);
	}

	inline static int32_t get_offset_of_timeElapsed_9() { return static_cast<int32_t>(offsetof(Cannon_t2011120925, ___timeElapsed_9)); }
	inline float get_timeElapsed_9() const { return ___timeElapsed_9; }
	inline float* get_address_of_timeElapsed_9() { return &___timeElapsed_9; }
	inline void set_timeElapsed_9(float value)
	{
		___timeElapsed_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
