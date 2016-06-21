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

// Coinoccurance
struct  Coinoccurance_t2224157610  : public MonoBehaviour_t3012272455
{
public:
	// System.Single Coinoccurance::start_time
	float ___start_time_2;
	// UnityEngine.GameObject Coinoccurance::CoinPrefab
	GameObject_t4012695102 * ___CoinPrefab_3;

public:
	inline static int32_t get_offset_of_start_time_2() { return static_cast<int32_t>(offsetof(Coinoccurance_t2224157610, ___start_time_2)); }
	inline float get_start_time_2() const { return ___start_time_2; }
	inline float* get_address_of_start_time_2() { return &___start_time_2; }
	inline void set_start_time_2(float value)
	{
		___start_time_2 = value;
	}

	inline static int32_t get_offset_of_CoinPrefab_3() { return static_cast<int32_t>(offsetof(Coinoccurance_t2224157610, ___CoinPrefab_3)); }
	inline GameObject_t4012695102 * get_CoinPrefab_3() const { return ___CoinPrefab_3; }
	inline GameObject_t4012695102 ** get_address_of_CoinPrefab_3() { return &___CoinPrefab_3; }
	inline void set_CoinPrefab_3(GameObject_t4012695102 * value)
	{
		___CoinPrefab_3 = value;
		Il2CppCodeGenWriteBarrier(&___CoinPrefab_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
