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
// UnityEngine.Transform
struct Transform_t284553113;

#include "AssemblyU2DCSharp_AbstractBehavior320735412.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Shield
struct  Shield_t2475494281  : public AbstractBehavior_t320735412
{
public:
	// UnityEngine.GameObject Shield::target
	GameObject_t4012695102 * ___target_6;
	// UnityEngine.Transform Shield::_t
	Transform_t284553113 * ____t_7;
	// System.Single Shield::start_time
	float ___start_time_8;

public:
	inline static int32_t get_offset_of_target_6() { return static_cast<int32_t>(offsetof(Shield_t2475494281, ___target_6)); }
	inline GameObject_t4012695102 * get_target_6() const { return ___target_6; }
	inline GameObject_t4012695102 ** get_address_of_target_6() { return &___target_6; }
	inline void set_target_6(GameObject_t4012695102 * value)
	{
		___target_6 = value;
		Il2CppCodeGenWriteBarrier(&___target_6, value);
	}

	inline static int32_t get_offset_of__t_7() { return static_cast<int32_t>(offsetof(Shield_t2475494281, ____t_7)); }
	inline Transform_t284553113 * get__t_7() const { return ____t_7; }
	inline Transform_t284553113 ** get_address_of__t_7() { return &____t_7; }
	inline void set__t_7(Transform_t284553113 * value)
	{
		____t_7 = value;
		Il2CppCodeGenWriteBarrier(&____t_7, value);
	}

	inline static int32_t get_offset_of_start_time_8() { return static_cast<int32_t>(offsetof(Shield_t2475494281, ___start_time_8)); }
	inline float get_start_time_8() const { return ___start_time_8; }
	inline float* get_address_of_start_time_8() { return &___start_time_8; }
	inline void set_start_time_8(float value)
	{
		___start_time_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
