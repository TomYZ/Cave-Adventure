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

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ItemOccurance
struct  ItemOccurance_t1907505480  : public MonoBehaviour_t3012272455
{
public:
	// System.Single ItemOccurance::start_time_heart
	float ___start_time_heart_2;
	// System.Single ItemOccurance::start_time_boost
	float ___start_time_boost_3;
	// UnityEngine.GameObject ItemOccurance::heart
	GameObject_t4012695102 * ___heart_4;
	// UnityEngine.GameObject ItemOccurance::boost
	GameObject_t4012695102 * ___boost_5;

public:
	inline static int32_t get_offset_of_start_time_heart_2() { return static_cast<int32_t>(offsetof(ItemOccurance_t1907505480, ___start_time_heart_2)); }
	inline float get_start_time_heart_2() const { return ___start_time_heart_2; }
	inline float* get_address_of_start_time_heart_2() { return &___start_time_heart_2; }
	inline void set_start_time_heart_2(float value)
	{
		___start_time_heart_2 = value;
	}

	inline static int32_t get_offset_of_start_time_boost_3() { return static_cast<int32_t>(offsetof(ItemOccurance_t1907505480, ___start_time_boost_3)); }
	inline float get_start_time_boost_3() const { return ___start_time_boost_3; }
	inline float* get_address_of_start_time_boost_3() { return &___start_time_boost_3; }
	inline void set_start_time_boost_3(float value)
	{
		___start_time_boost_3 = value;
	}

	inline static int32_t get_offset_of_heart_4() { return static_cast<int32_t>(offsetof(ItemOccurance_t1907505480, ___heart_4)); }
	inline GameObject_t4012695102 * get_heart_4() const { return ___heart_4; }
	inline GameObject_t4012695102 ** get_address_of_heart_4() { return &___heart_4; }
	inline void set_heart_4(GameObject_t4012695102 * value)
	{
		___heart_4 = value;
		Il2CppCodeGenWriteBarrier(&___heart_4, value);
	}

	inline static int32_t get_offset_of_boost_5() { return static_cast<int32_t>(offsetof(ItemOccurance_t1907505480, ___boost_5)); }
	inline GameObject_t4012695102 * get_boost_5() const { return ___boost_5; }
	inline GameObject_t4012695102 ** get_address_of_boost_5() { return &___boost_5; }
	inline void set_boost_5(GameObject_t4012695102 * value)
	{
		___boost_5 = value;
		Il2CppCodeGenWriteBarrier(&___boost_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
